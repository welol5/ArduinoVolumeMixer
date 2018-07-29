int prevLevels[5];
String output = "";
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  output = "";
  int levels[5];
  for(int i = 0; i < 5; i++){
    levels[i] = analogRead(i);
  }

  output += "[0,";
  for(int i = 0; i < 5; i++){

    //map the analog values to useable values
    levels[i] = map(levels[i],0,1023,0,100);
    
    output += levels[i];
    if(!(i == 5-1)){
      output += ",";
    }
  }
  output += ",0]\n";
  Serial.print(output);

  //sleep
  delay(100);
}
