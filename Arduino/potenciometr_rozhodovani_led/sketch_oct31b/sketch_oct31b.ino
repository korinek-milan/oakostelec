#define LED_GREEN 7
#define LED_RED 8
void setup() {
  // put your setup code here, to run once:
pinMode(LED_GREEN, OUTPUT);
pinMode(LED_RED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  int pVal = analogRead(A0);

  if (pVal > 512)
  {
    digitalWrite(LED_GREEN, HIGH);    
    digitalWrite(LED_RED, LOW); 
  }
  else
  {
    digitalWrite(LED_GREEN, LOW);    
    digitalWrite(LED_RED, HIGH); 
  }

}
