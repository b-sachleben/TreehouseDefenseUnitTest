﻿using Xunit;
using TreehouseDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense.Tests
{
    public class MapLocationTests
    {
        [Fact()]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);

            var exception = Assert.Throws<OutOfBoundsException>(() => new MapLocation(3, 3, map));
        }

        [Fact()]
        public void InRangeOfWithRange1()
        {
            var map = new Map(3, 3);
            var target = new MapLocation(0, 0, map);

            Assert.True(target.InRangeOf(new MapLocation(1, 1, map), 1));
        }
    }
}