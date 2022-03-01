# GraphClientSample Application

To run this sample application locally, you need to do the following things.

Register an Azure AD application, as described [here](https://github.com/Blazorade/Blazorade-MSAL/wiki/Getting-Started#register-application-with-azure-ad). Copy the *application (client) ID* and *directory (tenant) ID* to be used below.

> Note that the redirect URI must match the URL that you are running your application on your local computer with. In the [launch settings](./Properties/launchSettings.json) this is configured to `https://localhost:7125`.

Make sure that in the [`wwwroot`](./wwwroot/) folder you have an `appsettings.json` file. This file is intentionally left out of the source code, because of the potentially sensitive data it may contain. Add the following contents to the settings file.

``` JSON
{
    "app": {
        "clientId": "<Application's client ID>",
        "tenantId": "<The tenant ID>"
    }
}
```

Set the `clientId` and `tenantId` settings to the values you copied above. Now you should be able to run the application locally.