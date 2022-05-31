#include <DHT.h>;

#define DHTPIN 8
#define DHTTYPE DHT22
DHT dht(DHTPIN, DHTTYPE);


int chk;
float hum;
float temp;
int soilMoistureValue = 0;
int soilmoisturepercent=0;

void setup()
{
  Serial.begin(9600);
  dht.begin();
}

void loop()
{
    soilMoistureValue = analogRead(A1);
    int Photoresistor = analogRead(A0);
    delay(2000);
    hum = dht.readHumidity();
    temp= dht.readTemperature();
    Serial.println(soilMoistureValue);
    Serial.print("Humidity: ");
    Serial.print(hum);
    Serial.print(" %, Temp: ");
    Serial.print(temp);
    Serial.println(" Celsius");
    Serial.print("Photoresistor: ");
    Serial.println(Photoresistor);
    delay(10000);
}
