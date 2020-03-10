using System;
using System.Collections.Generic;
using System.Text;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;


namespace provaAcNetDll
{
public class Classe
{
[CommandMethod("HelloWorld")]
public void HelloWorldCommand()
{
Editor ed =
Application.DocumentManager.MdiActiveDocument.Editor;
ed.WriteMessage("Hello Basler&Hofmann");
}

}
}