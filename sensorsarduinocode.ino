

#include <ESP8266WiFi.h>

#include "DHT.h"   

#define DHTTYPE DHT11  
#define dht_dpin 0      //GPIO-0 D3 pin of nodemcu

const char* ssid = "Stefan";
const char* password = "mafia2911";


int WET= 16;
int DRY= 2;

int sense_Pin = 0;
int valueSoil = 0;


DHT dht(dht_dpin, DHTTYPE);
WiFiServer server(80);

void setup(void)
{
dht.begin();
  Serial.begin(9600);
  delay(10);
  pinMode(WET, OUTPUT);
  pinMode(DRY, OUTPUT);
  pinMode(D1, OUTPUT);

// Connect to WiFi network
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);
  WiFi.begin(ssid, password);     //Begin WiFi

 
while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected");


  // Start the server
  server.begin();
  Serial.println("Server started");

  // Print the IP address on serial monitor
  Serial.print("Use this URL to connect: ");
  Serial.print("http://");    //URL IP to be typed in mobile/desktop browser
  Serial.print(WiFi.localIP());
  Serial.println("/");

}


void loop() {

   digitalWrite(D1, HIGH); // Set pin 7 as "high" or turn it on
  Serial.println("Should be on"); // prints that the pump should be on
  delay(1000); // 10 second delay
  digitalWrite(D1, LOW); // Set pin 7 as "low" or turn it off
  Serial.println("Should be off"); // prints that the pump should be off
  delay(1000); // another 10 second delay

// Check if a client has connected

  WiFiClient client = server.available();
  if (!client) {
    return;
  }

  // Wait until the client sends some data

  Serial.println("new client");

  while(!client.available()){
    delay(1);
  }
  // Read the first line of the request

  String request = client.readStringUntil('\r');
  Serial.println(request);
  client.flush();

float h =0.0;  //Humidity level
float t =dht.readTemperature();  //Temperature in celcius
float f =0.0;  //Temperature in fahrenheit

   // Match the request

  int value = LOW;
 if (request.indexOf("/Up=ON") != -1)  {
     h = dht.readHumidity();    //Read humidity level
     t = dht.readTemperature(); //Read temperature in celcius
     f = (h * 1.8) + 32;        //Temperature converted to Fahrenheit
    value = HIGH;
  }

  // Return the response

  client.println("HTTP/1.1 200 OK");
  client.println("Content-Type: text/html");
  client.println(""); //  do not forget this one
  client.println("<!DOCTYPE HTML>");
  client.println("<html>");
  client.println("<h1 align=center>Temperature & Humidity Monitoring with DHT11</h1><br><br>");
  client.print("Temperature in Celsius =");
  client.println(t);
  client.println("<br>");
  client.print("Temperature in Fahrenheit =");
  client.println(f);
  client.println("<br>");
  client.print("Humidity =");
  client.println(h);
  client.print(" %");   
  client.print("Moisture =");
  client.println(valueSoil);
  client.println("<br>");  
  client.println();
 

    Serial.print("MOISTURE LEVEL : ");
    valueSoil= analogRead(sense_Pin);
    valueSoil= valueSoil;

   Serial.println(value);

        if(valueSoil<50)
        {
            digitalWrite(WET, HIGH);
        }

       else
       {
           digitalWrite(DRY,HIGH);
       }

       delay(1000);
       digitalWrite(WET,LOW);
       digitalWrite(DRY, LOW);

  if(value == HIGH) {
    client.println("Updated");
  } else {
    client.print("Not Updated");
  }
  client.println("<br><br>");
  client.println("<a href=\"/Up=ON\"\"><button>Update Temperature & Humidity</button></a><br />");  
  client.println("</html>");
  delay(1);
  Serial.println("Client disconnected");
  Serial.println("");
  Serial.println(dht.readTemperature());
  int digitalValue = digitalRead(D4);
  Serial.print("Analog reading: ");
  Serial.print(digitalValue);
}
