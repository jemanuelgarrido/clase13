using CreaciondeSuperheroes;

Superman superM = new Superman();

superM.fuerza = 150;
superM.nombre = "Clark Kent";
superM.agilidad = 100;

//superM.presentarse();
//superM.salvarElMundo();
//superM.volar();
//Console.WriteLine("Superman tiene una fuerza de {0}", superM.fuerza);
//Console.WriteLine("Superman se llama {0}", superM.nombre);

SuperheroeDB superh = new SuperheroeDB();
//superh.CrearTablaHeroe();
superh.CrearTablaHeroe(superM);
Console.ReadLine();