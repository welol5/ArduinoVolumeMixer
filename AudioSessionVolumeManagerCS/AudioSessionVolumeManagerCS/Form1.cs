/*TODO:
 * USE VOLUMECHANGED EVENTS TO UPDATE SLIDERS
 * MAKE VOLUME SESSION LIST UPDATE
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;
using System.Text.RegularExpressions;

using System.IO.Ports;
using System.Threading;

namespace AudioSessionVolumeManagerCS
{

    public partial class AudioSessionVolumeManagerCS : Form
    {
        //audio vars
        MMDevice device;
        AudioEndpointVolume masterVolume;
        SessionCollection sessions;
        int[] currentSelectedIndex = { -1, -1, -1, -1 };

        //serial vars
        SerialPort port = null;
        Thread readThread;
        private bool serialRead;
        string[] levels;

        public AudioSessionVolumeManagerCS()
        {
            InitializeComponent();

            //intialize audio stuff
            var deviceEnumerator = new MMDeviceEnumerator();
            device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            masterVolume = device.AudioEndpointVolume;
            updateMasterVolumeSlider();
            masterVolume.OnVolumeNotification += endpointVolumeNotification;

            //add the session volumes to the list
            updateSessions();
            device.AudioSessionManager.OnSessionCreated += sessionCreatedNotificaton;

            //intialize serial stuff
            string portName;
            foreach(string s in SerialPort.GetPortNames())
            {
                //Debug.WriteLine(s);
                ComSelector.Items.Add(s);
            }
            //readThread = new Thread(read);
            //port = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One);
            //port.Open();
            //serialRead = true;
            //readThread.Start();
        }

        //master volume
        private void MasterMuteButton_Click(object sender, EventArgs e)
        {
            masterVolume.Mute = !masterVolume.Mute;
        }
        void endpointVolumeNotification(AudioVolumeNotificationData data)
        {
            try
            {
                this.Invoke(new Action(delegate ()
                {
                    updateMasterVolumeSlider();
                }));
            }
            catch { }
        }
        void updateMasterVolumeSlider()
        {
            MasterVolumeSlider.Value = (int)(masterVolume.MasterVolumeLevelScalar * 1000);
        }
        private void MasterVolumeSlider_Scroll(object sender, EventArgs e)
        {
            try
            {
                masterVolume.MasterVolumeLevelScalar = (float)(MasterVolumeSlider.Value / 1000.0);
            } catch { }
        }

        //program volumes
        void updateSessions()
        {
            Session1Selector.Items.Clear();
            Session2Selector.Items.Clear();
            Session3Selector.Items.Clear();
            Session4Selector.Items.Clear();

            sessions = device.AudioSessionManager.Sessions;
            for (int i = 0; i < sessions.Count; i++)
            {
                Session1Selector.Items.Add(Process.GetProcessById((int)(sessions[i].GetProcessID)).ProcessName);
                Session2Selector.Items.Add(Process.GetProcessById((int)(sessions[i].GetProcessID)).ProcessName);
                Session3Selector.Items.Add(Process.GetProcessById((int)(sessions[i].GetProcessID)).ProcessName);
                Session4Selector.Items.Add(Process.GetProcessById((int)(sessions[i].GetProcessID)).ProcessName);
            }
        }
        void sessionCreatedNotificaton(object sender, IAudioSessionControl newSession)
        {
            try
            {
                this.Invoke(new Action(delegate ()
                {
                    device.AudioSessionManager.RefreshSessions();
                    updateSessions();
                }));
            } catch { }
        }

        //first session
        private void Session1Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSlider1Position();
            currentSelectedIndex[0] = Session1Selector.SelectedIndex;
        }
        void setSlider1Position()
        {
            //Debug.WriteLine(Session1Selector.SelectedIndex);
            Session1Volume.Value = (int)(sessions[Session1Selector.SelectedIndex].SimpleAudioVolume.Volume*1000);
        }
        private void Session1Volume_Scroll(object sender, EventArgs e)
        {
            sessions[Session1Selector.SelectedIndex].SimpleAudioVolume.Volume = (float)(Session1Volume.Value / 1000.0);
        }

        //second session
        private void Session2Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSlider2Position();
            currentSelectedIndex[1] = Session2Selector.SelectedIndex;
        }
        void setSlider2Position()
        {
            Session2Volume.Value = (int)(sessions[Session2Selector.SelectedIndex].SimpleAudioVolume.Volume);
        }
        private void Session2Volume_Scroll(object sender, EventArgs e)
        {
            sessions[Session2Selector.SelectedIndex].SimpleAudioVolume.Volume = (float)(Session2Volume.Value / 1000.0);
        }

        //third session
        private void Session3Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSlider3Position();
            currentSelectedIndex[2] = Session3Selector.SelectedIndex;
        }
        void setSlider3Position()
        {
            Session3Volume.Value = (int)(sessions[Session3Selector.SelectedIndex].SimpleAudioVolume.Volume);
        }
        private void Session3Volume_Scroll(object sender, EventArgs e)
        {
            sessions[Session3Selector.SelectedIndex].SimpleAudioVolume.Volume = (float)(Session3Volume.Value / 1000.0);
        }

        //fourth session
        private void Session4Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSlider4Position();
            currentSelectedIndex[3] = Session4Selector.SelectedIndex;
        }
        void setSlider4Position()
        {
            Session4Volume.Value = (int)(sessions[Session4Selector.SelectedIndex].SimpleAudioVolume.Volume);
        }
        private void Session4Volume_Scroll(object sender, EventArgs e)
        {
            sessions[Session4Selector.SelectedIndex].SimpleAudioVolume.Volume = (float)(Session4Volume.Value / 1000.0);
        }

        //serial
        public void read()
        {
            while (serialRead)
            {
                try
                {
                    string data = port.ReadLine();
                    //Debug.WriteLine(data);
                    levels = data.Split(',');
                    /*foreach (string s in levels)
                    {
                        Debug.WriteLine(s);
                    }*/

                    //TODO: set the serial levels to the volume levels
                    masterVolume.MasterVolumeLevelScalar = (float)(Int32.Parse(Regex.Match(levels[1], "\\d+").Value) / 100.0);
                    if(currentSelectedIndex[0] != -1)
                        sessions[currentSelectedIndex[0]].SimpleAudioVolume.Volume = (float)(Int32.Parse(Regex.Match(levels[2], "\\d+").Value) / 100.0);
                    if (currentSelectedIndex[1] != -1)
                        sessions[currentSelectedIndex[1]].SimpleAudioVolume.Volume = (float)(Int32.Parse(Regex.Match(levels[3], "\\d+").Value) / 100.0);
                    if (currentSelectedIndex[2] != -1)
                        sessions[currentSelectedIndex[2]].SimpleAudioVolume.Volume = (float)(Int32.Parse(Regex.Match(levels[4], "\\d+").Value) / 100.0);
                    if (currentSelectedIndex[3] != -1)
                        sessions[currentSelectedIndex[3]].SimpleAudioVolume.Volume = (float)(Int32.Parse(Regex.Match(levels[5], "\\d+").Value) / 100.0);
                }
                catch (TimeoutException) { }
                catch (IndexOutOfRangeException) { }
                catch { }
            }
        }
        private void ComSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port == null)
            {
                readThread = new Thread(read);
                port = new SerialPort(ComSelector.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
                port.Open();
                serialRead = true;
                readThread.Start();
            }
        }

        private void AudioSessionVolumeManagerCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialRead = false;
        }
    }
}
