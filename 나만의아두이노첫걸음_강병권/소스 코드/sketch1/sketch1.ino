int pinLed = 13;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); // bit 단위
  pinMode(pinLed, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("Hello World");
  delay(1000);
  Serial.println("이인규");
  digitalWrite(pinLed, HIGH);
  delay(1000);
  digitalWrite(pinLed, LOW);
  delay(1000);
  Serial.end();
}
