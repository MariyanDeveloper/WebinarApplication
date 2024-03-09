using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace WebinarApplication;

[Transaction(TransactionMode.Manual)]
[Regeneration(RegenerationOption.Manual)]
public class WebinarCreateViewsCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        var uiApplication = commandData.Application;
        var application = uiApplication.Application;
        var uiDocument = uiApplication.ActiveUIDocument;
        var document = uiDocument.Document;
        var documentName = application.VersionNumber;
        TaskDialog.Show("Title", $"Revit Version is : {documentName}");
        return Result.Succeeded;
    }
}



public interface IMyCommand
{
    void Execute();
}
public class MyCommand : IMyCommand
{
    public void Execute()
    {
        //here you would write actual implementation
    }
}