using AdapterExDB;
using AdapterExDB.ConcreteClases;

//El objetivo seria insertar y leer datos desde la BD legacy hecha en excel

ExcelDB dbLegacy = new ExcelDB();
DatabaseAdapter adaptador = new DatabaseAdapter(dbLegacy);

SAPDB newSystem = new SAPDB(adaptador);

newSystem.SaveData("Datos importantes");
newSystem.LoadData();