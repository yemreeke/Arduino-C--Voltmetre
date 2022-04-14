float VoltajCikis = 0.0;
float VoltajGiris = 0.0;
float Direnc1 = 100000.0; // 100K ohm direnç
float Direnc2 = 10000.0; // 10K ohm direnç
bool olcum = false;
double Deger = 0;
void setup() {
  Serial.begin(115200);
}
void loop() {
  if (Serial.available()) {
    char veri = Serial.read();
    if (veri == 'X') { // Şifre isteğinde bulunma mesajı
      Serial.println("yemreeke"); //Haberleşme için Şifre
    }
    else if (veri == 'A') { //Ölçümü Başlatma mesajı
      olcum = true;
    }
    else if (veri == 'K') { //Ölçümü Durdurma mesajı
      olcum = false;
    }
  }
  if (olcum) {
    Deger = 0;
    for (int i = 0; i < 10; i++) {
      Deger += analogRead(A0);
    }
    Deger /= 10.0;
    VoltajCikis = (Deger * 5.0) / 1024.0;
    VoltajGiris = VoltajCikis / (Direnc2 / (Direnc1 + Direnc2));
    Serial.println(VoltajGiris, 3);
  }
}
