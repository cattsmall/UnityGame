/* taken from https://github.com/dat290/Unity-3D-Small-Scripting-Assignment */

public var health : int = 100;
 var points = int;
 function Update (){ 
     if (health <= 0) {
        kill();
      }
 }
 
 function kill() {
     print ("you are dead");
 }