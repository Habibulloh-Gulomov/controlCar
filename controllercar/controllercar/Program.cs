using controllercar;
int speed = 5;
int battery = 2;
var Car = new ControlCar(speed, battery);
int distance = 800;
var raceTrack = new raceTrack(distance);

var malibu = ControlCar.Nitro();
var result = raceTrack.TryFinishTrack(malibu);
Console.WriteLine(result);