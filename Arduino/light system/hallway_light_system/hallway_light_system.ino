const int MOTIOND = 2;
const int ADJUSTR = 9;
const int ADJUSTG = 10;
const int ADJUSTB = 11;


void setup() {
  pinMode(MOTIOND, INPUT);
  pinMode(ADJUSTR, OUTPUT);
  pinMode(ADJUSTG, OUTPUT);
  pinMode(ADJUSTB, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if (digitalRead(MOTIOND) == HIGH) {
    analogWrite(ADJUSTR, 0);
    analogWrite(ADJUSTG, 150);
    analogWrite(ADJUSTB, 250);
    Serial.println("active");
  }
  else {
    analogWrite(ADJUSTR, 255);
    analogWrite(ADJUSTG, 255);
    analogWrite(ADJUSTB, 255);
  }
}
