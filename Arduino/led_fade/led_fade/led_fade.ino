int led = 9;         // jiny zpusob oznaceni pinu
int brightness = 0;  // svitivost
int fadeAmount = 5;  // pocet bodu o ktere menim hodnotu

// the setup routine runs once when you press reset:
void setup()
{
  pinMode(led, OUTPUT);
}

// the loop routine runs over and over again forever:
void loop() {

  analogWrite(led, brightness);//analogovy zapis -> hodnota se meni postupne

  // change the brightness for next time through the loop:
  brightness = brightness + fadeAmount;

  // reverse the direction of the fading at the ends of the fade:
  if (brightness <= 0 || brightness >= 255) {
    fadeAmount = fadeAmount * -1;//otocim prirustek
  }
  delay(30);
}
