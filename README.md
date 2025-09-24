# Principios-Solid
 
Principio de Responsabilidad Única
El mini proyecto cuenta con varios scripts:
-BalaController
-WeaponController
-CamaraController
-Jump
-PlayerController
-Running

Cada script cuenta con una única funcionalidad en el proyecto

Inversión de Dependencias
Se implementó una interfaz llamada IShootable la cual posee un método Shoot(), haciendo que Weapon Controller no dependa de BalaController, sino de IShootable, pudiendo así, tener múltiples tipos de balas (Laser, Rocket) y si implementan la interfaz, seguirá funcionando igual
