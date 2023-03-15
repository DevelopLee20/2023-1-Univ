/* 사용한 함수 정리
Serial.begin(int);
Serial.println(String);
delay(int);
Seiral.end(); -> print문만 제어됨.
pinMode(pin_name, OUTPUT);

개념정리
13번 핀은 아두이노 자체 LED
*/

int pinLed = 13;

void setup() {
  Serial.begin(9600); // bit 단위
  pinMode(pinLed, OUTPUT);
}

void loop() {
  Serial.println("Hello World");
  delay(1000);
  Serial.println("이인규");
  digitalWrite(pinLed, HIGH);
  delay(1000);
  digitalWrite(pinLed, LOW);
  delay(1000);
  Serial.end();
}
