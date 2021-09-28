﻿using System;
using Microsoft.AspNetCore.Mvc;
using MetricsManager.Controllers;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace MetricsManagerTest
{
    public class RamMetricsControllerTest
    {
        RamMetricsController _controller;
        Mock<ILogger<RamMetricsController>> _mock;

        public RamMetricsControllerTest()
        {
            _mock = new Mock<ILogger<RamMetricsController>>();

            _controller = new RamMetricsController(_mock.Object);
        }

        [Fact]
        public void GetMetricsFromAgentTest()
        {
            var agentId = 1;
            var fromTime = new TimeSpan(1, 2, 3, 4);
            var toTime = new TimeSpan(10, 20, 30, 40);

            var result = _controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsFromAllCluster()
        {
            var fromTime = new TimeSpan(1, 2, 3, 4);
            var toTime = new TimeSpan(10, 20, 30, 40);

            var result = _controller.GetMetricsFromAllCluster(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}