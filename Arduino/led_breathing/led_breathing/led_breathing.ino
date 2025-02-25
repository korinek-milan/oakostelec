int ledPin = 9;         //jiny zpusob vyberu pinu...stejne jako #define LED_PIN 9

float smoothness_pts = 500; //larger=slower change in brightness  
float gamma = 0.14; // affects the width of peak (more or less darkness)
float beta = 0.5; // shifts the gaussian to be symmetric

void setup()
{
  Serial.begin(9600);//chci zacit vypisovat pro kontrolu
  pinMode(ledPin,OUTPUT);
}


void loop()
{
  for (int ii=0;ii<smoothness_pts;ii++)
  {
    float pwm_val = 255.0*(exp(-(pow(((ii/smoothness_pts)-beta)/gamma,2.0))/2.0));//nejaka matematicka funkce, ktera mi vrati jedno cislo
    analogWrite(ledPin,int(pwm_val));
    delay(5);
    Serial.println((pwm_val));//kontrolni vypis
  }
}