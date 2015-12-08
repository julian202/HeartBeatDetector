/* Sweep
 by BARRAGAN <http://barraganstudio.com> 
 This example code is in the public domain.

 modified 8 Nov 2013
 by Scott Fitzgerald
 http://arduino.cc/en/Tutorial/Sweep
*/ 

#include <Servo.h> 
 
String incomingString;
char incomingSerialValue;
char firstChar;
char secondChar;
String incomingStringStepper;
long incomingLongStepper;
float incomingFloatStepper;

//Servo myservo;  // create servo object to control a servo 
                // twelve servo objects can be created on most boards
Servo myservoWithShield; 
 
int pos = 0;    // variable to store the servo position 
 
void setup() 
{ 
  pinMode(11,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(12,OUTPUT);
  pinMode(13,OUTPUT);
  //digitalWrite(13, LOW);
  Serial.begin(9600);
  //myservo.attach(11);  // attaches the servo on pin 11 to the servo object 
  myservoWithShield.attach(6);  // attaches the servo on pin 11 to the servo object 
} 
 
void loop() 
{ 
  
  if (Serial.available() > 0) {
    
    incomingString="";  //important.
    while(Serial.available()) {
      incomingSerialValue = Serial.read();
      incomingString.concat(incomingSerialValue);
      delay (10);
    }
    
   firstChar=incomingString.charAt(0);
   secondChar=incomingString.charAt(1);
   
   if (firstChar == 'm'){
     digitalWrite(13, HIGH);
     delay(350);
     digitalWrite(13, LOW);
   }
   
   if (firstChar == 's'){ //stop the dc motor by setting the PWM signal to zero V
     //digitalWrite(9, HIGH);   //engage the Brake for Channel A
     analogWrite(3, 0);
     analogWrite(11, 0);
   }
   
   if (firstChar == 'z'){  // move servo to specified angle.
      incomingStringStepper=incomingString.substring(2);
      incomingFloatStepper=incomingStringStepper.toFloat();
      //Serial.println("moving stepper");  
      //myservo.write(incomingFloatStepper);
      myservoWithShield.write(incomingFloatStepper);
   }
   if (firstChar == 't'){  // move dc motor the specified amount of time.
      if (secondChar == 'f'){  //forward direction
        digitalWrite(12, HIGH); //Establishes forward direction of Channel A
      }
      else { //backward direction
         digitalWrite(12, LOW); //Establishes back direction of Channel A
      }    
      incomingStringStepper=incomingString.substring(2);
      incomingLongStepper=incomingStringStepper.toInt();
      //Serial.println("moving stepper");  
      analogWrite(3, 155);   //Spins the motor on Channel A 
      delay(incomingLongStepper);
      analogWrite(3, 0);   //Spins the motor on Channel A 
   }  
   
   //The following code has been disabled to disable the motor because it interferes with pin 13 which I want to send signals to the CT-machine
   /*if (firstChar == 'p'){  // move dc motor the specified amount of time.
      if (secondChar == 'f'){  //forward direction
        digitalWrite(13, HIGH); //Establishes forward direction of Channel A
      }
      else { //backward direction
         digitalWrite(13, LOW); //Establishes back direction of Channel A
      }    
      incomingStringStepper=incomingString.substring(2);
      incomingLongStepper=incomingStringStepper.toInt();
      //Serial.println("moving stepper");  
      analogWrite(11, 155);   //Spins the motor on Channel B 
      delay(incomingLongStepper);
      analogWrite(11, 0);   //Spins the motor on Channel B 
   }  */
   
   
   Serial.print(incomingString);
   Serial.print(firstChar);
   Serial.print(secondChar);
   
  }
} 

