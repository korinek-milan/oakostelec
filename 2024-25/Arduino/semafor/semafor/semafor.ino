int cervena = 13;
int zluta = 12;
int zelena = 8;


// the setup routine runs once when you press reset:
void setup()
{
  pinMode(cervena, OUTPUT);
  pinMode(zluta, OUTPUT);
  pinMode(zelena, OUTPUT);
}

// the loop routine runs over and over again forever:
void loop() {

  digitalWrite(cervena, HIGH);
  digitalWrite(zluta, LOW);
  digitalWrite(zelena, LOW);
  delay(3000);
  digitalWrite(zluta, HIGH);
  delay(2000);
  digitalWrite(cervena, LOW);
  digitalWrite(zluta, LOW);
  digitalWrite(zelena, HIGH);
  delay(3000);
  digitalWrite(cervena, LOW);
  digitalWrite(zluta, HIGH);
  digitalWrite(zelena, LOW);
  delay(2000);
  digitalWrite(cervena, HIGH);
  digitalWrite(zluta, LOW);
  digitalWrite(zelena, LOW);
}
