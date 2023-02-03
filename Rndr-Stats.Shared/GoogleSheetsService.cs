using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Sheets.v4;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.Net;

namespace Rndr_Stats.Shared
{
    internal class GoogleSheetsService
    {
        internal static void LoadCredentialsAndInitializeSheetsService()
        {
            // Load the credentials.json file
            var credentials = GoogleCredential.FromFile("credentials.json");

            // Create a SheetsService instance
            var sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credentials,
                ApplicationName = "My Google Sheets App"
            });
        }
    }
}
