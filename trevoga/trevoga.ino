#include <SoftwareSerial.h>

SoftwareSerial gprsSerial(7, 8);

int btnPin = 12;
int PindlaPIR = 2;

void setup()
{
    gprsSerial.begin(19200);
    pinMode(PindlaPIR,INPUT);
    delay(500);
    pinMode(btnPin, OUTPUT);
}

void loop()
{
    int val = digitalRead(PindlaPIR);
    //Если датчик заметил,то подадим высокий сигнал
    if(val==1)
    {
      digitalWrite(btnPin,HIGH);
    }
    boolean currBtn = digitalRead(btnPin);
    if (currBtn==true) {
        //сразу после нажатия кнопки отправляем "тревожное" сообщение по заданному номеру
        sendTextMessage();
    }
    //Подождём, ибо Пировский датчик долго отходит
    delay(20000);
   
}

/*
 * Функция отправки SMS-сообщения
 */
void sendTextMessage() {
    // Устанавливает текстовый режим для SMS-сообщений
    gprsSerial.print("AT+CMGF=1\r");
    delay(100); // даём время на усваивание команды
    // Устанавливаем адресата: телефонный номер в международном формате
    gprsSerial.println("AT + CMGS = \"+79044033778\"");
    delay(100);
    // Пишем текст сообщения
    gprsSerial.println("Trevoga");
    delay(100);
    Serial.println('1');
    // Отправляем Ctrl+Z, обозначая, что сообщение готово
    gprsSerial.println((char)26);
}
