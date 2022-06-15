#pragma warning disable CS8602 // Dereference of a possibly null reference.
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace webapi_auth2.Conventions
{
    public class GroupingByNamespaceConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNamespace = controller.ControllerType.Namespace;
            var apiVersion = controllerNamespace.Split(".").Last().ToLower();
            if (!apiVersion.StartsWith("v")) { apiVersion = "v1"; }
            controller.ApiExplorer.GroupName = apiVersion;
        }
    }
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.
