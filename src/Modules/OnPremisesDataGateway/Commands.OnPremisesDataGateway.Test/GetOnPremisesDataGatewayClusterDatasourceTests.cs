﻿/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License.
 */

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.PowerBI.Commands.Common.Test;
using Microsoft.PowerBI.Commands.Profile.Test;
using Microsoft.PowerBI.Common.Api;
using Microsoft.PowerBI.Common.Api.Gateways.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Microsoft.PowerBI.Commands.OnPremisesDataGateway.Test
{
    [TestClass]
    public class GetOnPremisesDataGatewayClusterDatasourceTests
    {
        private static CmdletInfo GetOnPremisesDataGatewayClusterDatasourceInfo { get; } = new CmdletInfo(
            $"{GetOnPremisesDataGatewayClusterDatasource.CmdletVerb}-{GetOnPremisesDataGatewayClusterDatasource.CmdletName}",
            typeof(GetOnPremisesDataGatewayClusterDatasource));

        [TestMethod]
        [TestCategory("Interactive")]
        [TestCategory("SkipWhenLiveUnitTesting")] // Ignore for Live Unit Testing
        public void EndToEndGetOnPremisesDataGatewayClusterDatasource()
        {
            using (var ps = System.Management.Automation.PowerShell.Create())
            {
                // Arrange
                ProfileTestUtilities.ConnectToPowerBI(ps);
                ps.AddCommand(GetOnPremisesDataGatewayClusterDatasourceInfo)
                    .AddParameter(nameof(GetOnPremisesDataGatewayClusterDatasource.GatewayClusterId), Guid.NewGuid())
                    .AddParameter(nameof(GetOnPremisesDataGatewayClusterDatasource.GatewayClusterDatasourceId), Guid.NewGuid());

                // Act
                var result = ps.Invoke();

                // Assert
                TestUtilities.AssertNoCmdletErrors(ps);
                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public void GetOnPremisesDataGatewayClusterDatasourceReturnsExpectedResults()
        {
            // Arrange
            var gatewayClusterId = Guid.NewGuid();
            var GatewayClusterDatasourceId = Guid.NewGuid();

            var expectedResponse = new GatewayClusterDatasource
            {
                ClusterId = gatewayClusterId,
                Id = GatewayClusterDatasourceId,
                ConnectionDetails = "the connection details",
                CredentialType = "Basic",
                DatasourceErrorDetails = new List<DatasourceErrorDetails>
                {
                    new DatasourceErrorDetails
                    {
                        ErrorCode = "the error code",
                        ErrorMessage = "the error message",
                        GatewayName = "the gateway name",
                    },
                },
                DatasourceName = "the datasource name",
                DatasourceType = "SQL",
                Users = new List<DatasourceUser>(),
            };

            var client = new Mock<IPowerBIApiClient>();
            client.Setup(x => x.Gateways
                .GetGatewayClusterDatasource(gatewayClusterId, GatewayClusterDatasourceId, true))
                .ReturnsAsync(expectedResponse);

            var initFactory = new TestPowerBICmdletInitFactory(client.Object);
            var cmdlet = new GetOnPremisesDataGatewayClusterDatasource(initFactory)
            {
                GatewayClusterId = gatewayClusterId,
                GatewayClusterDatasourceId = GatewayClusterDatasourceId,
            };

            // Act
            cmdlet.InvokePowerBICmdlet();

            // Assert
            TestUtilities.AssertExpectedUnitTestResults(expectedResponse, client, initFactory);
        }

        [TestMethod]
        [TestCategory("Interactive")]
        [TestCategory("SkipWhenLiveUnitTesting")] // Ignore for Live Unit Testing
        public void EndToEndGetOnPremisesDataGatewayClusterDatasources()
        {
            using (var ps = System.Management.Automation.PowerShell.Create())
            {
                // Arrange
                ProfileTestUtilities.ConnectToPowerBI(ps);
                ps.AddCommand(GetOnPremisesDataGatewayClusterDatasourceInfo)
                    .AddParameter(nameof(GetOnPremisesDataGatewayClusterDatasource.GatewayClusterId), Guid.NewGuid());

                // Act
                var result = ps.Invoke();

                // Assert
                TestUtilities.AssertNoCmdletErrors(ps);
                Assert.IsNotNull(result);
            }
        }

        [TestMethod]
        public void GetOnPremisesDataGatewayClusterDatasourcesReturnsExpectedResults()
        {
            // Arrange
            var gatewayClusterId = Guid.NewGuid();
            var GatewayClusterDatasourceId = Guid.NewGuid();

            var expectedResponse = new GatewayClusterDatasource
            {
                ClusterId = gatewayClusterId,
                Id = GatewayClusterDatasourceId,
                ConnectionDetails = "the connection details",
                CredentialType = "Basic",
                DatasourceErrorDetails = new List<DatasourceErrorDetails>
                {
                    new DatasourceErrorDetails
                    {
                        ErrorCode = "the error code",
                        ErrorMessage = "the error message",
                        GatewayName = "the gateway name",
                    },
                },
                DatasourceName = "the datasource name",
                DatasourceType = "SQL",
                Users = new List<DatasourceUser>(),
            };

            var client = new Mock<IPowerBIApiClient>();
            client.Setup(x => x.Gateways
                .GetGatewayClusterDatasources(gatewayClusterId, true))
                .ReturnsAsync(new[] { expectedResponse });

            var initFactory = new TestPowerBICmdletInitFactory(client.Object);
            var cmdlet = new GetOnPremisesDataGatewayClusterDatasource(initFactory)
            {
                GatewayClusterId = gatewayClusterId,
            };

            // Act
            cmdlet.InvokePowerBICmdlet();

            // Assert
            TestUtilities.AssertExpectedUnitTestResults(expectedResponse, client, initFactory);
        }
    }
}