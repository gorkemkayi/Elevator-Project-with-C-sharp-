#include<ESP32Servo.h>
#define Ldr 36
int servoPin = 15;
int buzzerPin = 22;
unsigned long ISR1_Zaman = 250; //ms
//unsigned long ISR2_Zaman = 1;  //ms
//unsigned long ISR3_Zaman=2;

unsigned long ISR1_evvelkiMillis = 0;
//unsigned long ISR2_evvelkiMillis=0;
//unsigned long ISR3_evvelkiMillis=0;

//setting PWM properties
const int freq = 30000;
const int pwmChannel = 0;
const int resolution = 8;

int motor1Pin1 = 5;
int motor1Pin2 = 18;
int enable1Pin = 17;
String gelendeger;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(buzzerPin, OUTPUT);
  pinMode(motor1Pin1, OUTPUT);
  pinMode(motor1Pin2, OUTPUT);
  pinMode(enable1Pin, OUTPUT);
  pinMode(servoPin, OUTPUT);


  ledcSetup(pwmChannel, freq, resolution);
  ledcAttachPin(enable1Pin, pwmChannel);
}

void loop() {
  unsigned long currentMillis = millis();
  if (currentMillis - ISR1_evvelkiMillis >= ISR1_Zaman) {
    ISR1_evvelkiMillis = currentMillis;
    ISR_1();
  }

  if (Serial.available()) {
    char c = Serial.read();
    if (c == 'a') {
      digitalWrite(buzzerPin, HIGH);
    }
    else if (c == 'b') {
      digitalWrite(buzzerPin, LOW);
    }
    ///////Fan Ayarları/////////////////////////////
    else if (c == 'y') {
      yavasDondur();
    }
    else if (c == 'o') {
      ortaDondur();
    }
    else if (c == 'h') {
      hizliDondur();
    }
    else if (c == 'd') {
      Durdur();
    }
    else if (c == 'e') {
      terseYavas();
    }
    else if (c == 'f') {
      terseOrta();
    }
    else if (c == 'g') {
      terseHizli();
    }
    else if (c == 's') {
      servoDondur();
    }
    else if (c == 'r') {
      servoGeriDondur();
    }

    /////////////////////////////////////////////////////
  }



}


void ISR_1() {
  int Ldr_deger = analogRead(Ldr);
  if (Ldr_deger > 0 && Ldr_deger < 332 ) {
    Serial.println("Yuksek");
  }
  else if (Ldr_deger >= 332 && Ldr_deger < 3998) {
    Serial.println("Orta");
  }
  else if (Ldr_deger > 3998) {
    Serial.println("Az");
  }
}
void yavasDondur() {
  digitalWrite(motor1Pin1, HIGH);
  digitalWrite(motor1Pin2, LOW);
  ledcWrite(pwmChannel, 200);
}
void ortaDondur() {
  digitalWrite(motor1Pin1, HIGH);
  digitalWrite(motor1Pin2, LOW);
  ledcWrite(pwmChannel, 225);
}
void hizliDondur() {
  digitalWrite(motor1Pin1, HIGH);
  digitalWrite(motor1Pin2, LOW);
  ledcWrite(pwmChannel, 255);
}
void Durdur() {
  digitalWrite(motor1Pin1, LOW);
  digitalWrite(motor1Pin2, LOW);
  ledcWrite(pwmChannel, 255);
}
void terseYavas() {
  digitalWrite(motor1Pin1, LOW);
  digitalWrite(motor1Pin2, HIGH);
  ledcWrite(pwmChannel, 200);
}
void terseOrta() {
  digitalWrite(motor1Pin1, LOW);
  digitalWrite(motor1Pin2, HIGH);
  ledcWrite(pwmChannel, 225);
}
void terseHizli() {
  digitalWrite(motor1Pin1, LOW);
  digitalWrite(motor1Pin2, HIGH);
  ledcWrite(pwmChannel, 255);
}
void servoDondur() {
  for (int i = 0; i <= 3; i++) {
    digitalWrite (servoPin, HIGH);
    delayMicroseconds(2400);
    digitalWrite (servoPin, LOW);
    delay(20);
  }
}
void servoGeriDondur() {
  for (int i = 0; i <= 3; i++) {
    digitalWrite (servoPin, HIGH);
    delayMicroseconds(544);
    digitalWrite (servoPin, LOW);
    delay(20);
  }
}
