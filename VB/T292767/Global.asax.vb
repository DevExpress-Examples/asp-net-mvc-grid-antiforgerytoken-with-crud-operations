Imports System.Web.SessionState
Imports System.Web.Http

Public Class Global_asax
	Inherits System.Web.HttpApplication

	Sub Application_Start()
		AreaRegistration.RegisterAllAreas()

		WebApiConfig.Register(GlobalConfiguration.Configuration)
		FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
		RouteConfig.RegisterRoutes(RouteTable.Routes)
		AuthConfig.RegisterAuth()

		ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()

		AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
	End Sub

	Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
		Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
		'TODO: Handle Exception
	End Sub

End Class

