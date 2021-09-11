// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Examples.V8;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// The Main class for this application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The application's exit code.</returns>
        public static int Main(string[] args)
        {
            // Turn on detailed logging. This is useful for debugging your requests.
            // You should also replace INSERT_PATH_TO_DETAILED_LOGS_HERE to a file path that will
            // be used to write the detailed logs to. E.g. C:\\logs\\details.log
            // TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
            //    "INSERT_PATH_TO_DETAILED_LOGS_HERE", System.Diagnostics.SourceLevels.All);

            // If the API log doesn't give you enough details, then you can enable more low level
            // logging at grpc level. Keep in mind that this can get pretty detailed and long. The
            // grpc logs are written to stderr.
            // You can find all the supported environment variables here:
            // https://github.com/grpc/grpc/blob/master/doc/environment_variables.md
            // Environment.SetEnvironmentVariable("GRPC_VERBOSITY", "DEBUG");
            // Environment.SetEnvironmentVariable("GRPC_TRACE", "http");

            // If you simply want to try out a code example, you can create an instance of it here,
            // and call its Run method. E.g.

            // Optional: If you have specified these keys in the App.config file, you can skip
            // creating a GoogleAdsConfig object and do
            // GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            // string developerToken = "INSERT_YOUR_DEVELOPER_TOKEN_HERE";
            // string oAuth2clientId = "INSERT_OAUTH2_CLIENT_ID_HERE";
            // string oAuth2Secret = "INSERT_OAUTH2_CLIENT_SECRET_HERE";
            // string oAuth2RefreshToken = "INSERT_OAUTH2_REFRESH_TOKEN_HERE";
            // long loginCustomerId = long.Parse("INSERT_LOGIN_CUSTOMER_ID_HERE");

            /*           
                <add key = 'OAuth2Mode' value = 'APPLICATION' />
                <add key = 'OAuth2ClientId' value = '701833517764-30ffl3fg731m83eiet18r1t2pav6d5gh.apps.googleusercontent.com' />
                <add key = 'OAuth2ClientSecret' value = '7lP4ODmjfO9AVTp1OiudDcP_' />
                <add key = 'OAuth2RefreshToken' value = '1//09DHhiCTnjjmECgYIARAAGAkSNwF-L9IrcQK-l_6d_AWjLlcfPtZHbCfwswwb7dKaD575K99EACKiuoejMji8Qy-V6blJkviZ8QM' />
             */

            GoogleAdsConfig googleAdsConfig = new GoogleAdsConfig()
            {
                DeveloperToken = "N0N4otYUZraRNzOxUdQGhQ",
                //LoginCustomerId = "5025419334",
                //OAuth2ClientId = "701833517764-6sjju6n9v3o2s5m49pkrnj8ou1otju1s.apps.googleusercontent.com",
                //OAuth2ClientSecret = "c3YWq_goas2NV6v83FXu2qR0",
                OAuth2ClientId = "701833517764-30ffl3fg731m83eiet18r1t2pav6d5gh.apps.googleusercontent.com",
                OAuth2ClientSecret = "7lP4ODmjfO9AVTp1OiudDcP_",
                OAuth2RefreshToken = "1//09aLpNB7gSEgdCgYIARAAGAkSNwF-L9IrsTIJXM-dJKnffMCMN6UGegKv4JYhMAx0QGap6CJlmAat0SZUfDGEIJ9lMDVbtIO26RI"
            };

            GoogleAdsClient googleAdsClient = new GoogleAdsClient(googleAdsConfig);

            Console.WriteLine("Running the right project");

            // Run the code example. //

            //new AddCustomAudience().Run(googleAdsClient, 3660013635);
            new AddCustomerMatchUserList().Run(googleAdsClient, 3660013635);
            //new AddCampaigns().Run(googleAdsClient, 3660013635);
            //new AddAdGroups().Run(googleAdsClient, 3660013635, 11690754915);
            //new ListAccessibleCustomers().Run(googleAdsClient);
            //new GetCampaigns().Run(googleAdsClient, 3660013635);

            // Alternatively, you can pass command line arguments to run the code example. E.g.
            // V2.GetCampaigns --customerId=1234567890
            // The first argument has the form VersionName.ExampleName, e.g. V2.GetCampaigns to run
            // Google.Ads.GoogleAds.Examples.V2.GetCampaigns example.
            // The subsequent arguments can be inferred by looking at the Run method of the code
            // example and skipping the first parameter.
            // E.g. GetCampaigns.cs has a Run method is defined as
            //
            //     public void Run(GoogleAdsClient client, long customerId)
            //
            // So, this example can be run with the command line arguments
            //
            //     V2.GetCampaigns --customerId=1234567890
            return RunExamplesFromCommandLineArguments(args);
        }

        /// <summary>
        /// Runs the examples from command line arguments.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The application's exit code. The valid return codes are:
        /// /// <list type="bullet">
        /// <item><description>0. The code example ran successfully.</description></item>
        /// <item><description>1. The code example threw an exception and did not complete
        /// successfully.</description></item>
        /// <item><description>2. The application was invoked with an incorrect command line
        /// argument.</description></item>
        /// </list>
        /// </returns>
        private static int RunExamplesFromCommandLineArguments(string[] args)
        {
            ExampleRunner runner = new ExampleRunner();
            runner.LoadCodeExamples(Assembly.GetExecutingAssembly());

            if (args.Length == 0)
            {
                // Bad command line parameter.
                ShowUsage(runner);
                return 2;
            }

            string exampleName = args[0];
            try
            {
                runner.Run(exampleName, args.Skip(1));
                return 0;
            }
            catch (Exception e) when (e is KeyNotFoundException)
            {
                // First arg is not a valid example name.
                Console.WriteLine("First arg is not a valid example name");
                ShowUsage(runner);
                return 2;
            }
            catch (Exception e) when (e is ArgumentException)
            {
                // Args passed to runner are invalid
                Console.WriteLine(e.Message);
                Console.WriteLine(ExampleBase.GetUsage(runner.GetCodeExampleType(exampleName)));
                return 2;
            }
            catch (Exception e)
            {
                // Indicates a failure due to an unhandled exception.
                Console.WriteLine(e.Message);
                return 1;
            }
        }

        /// <summary>
        /// Prints program usage message.
        /// </summary>
        private static void ShowUsage(ExampleRunner runner)
        {
            string exeName = ExampleRunner.GetExecutableName();
            Console.WriteLine("Runs Google Ads API code examples");
            Console.WriteLine("Usage : dotnet {0} examplename [flags]\n", exeName);
            Console.WriteLine($"Supported examples: \n");
            runner.PrintAvailableExamples();
            Console.WriteLine("Press [Enter] to continue");
            Console.ReadLine();
        }
    }
}
