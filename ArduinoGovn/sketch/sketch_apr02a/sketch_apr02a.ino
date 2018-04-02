void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  pinMode(13,OUTPUT);
}

void loop() {
  if(Serial.available() !=0)
  {
    byte b = Serial.read();
    if(b ==49)
    {
      digitalWrite(13,HIGH);
    }
    //По аски 50=2
    else if(b==50)
    {
     digitalWrite(13,LOW); 
    }
   }
}
