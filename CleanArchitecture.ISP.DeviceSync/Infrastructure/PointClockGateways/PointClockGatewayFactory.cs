﻿using CleanArchitecture.ISP.DeviceSync.Domain.Brands.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.DeviceSync.Infrastructure.PointClockGateways;
internal static class PointClockGatewayFactory
{
    internal static IPointClockGenericGateway CreateGeneric(PointClock pointClock)
    {
        return pointClock.Brand switch
        {
            Brand.ControlID => new ControlIDGateway(pointClock),
            Brand.Henry => new HenryGateway(pointClock),
            _ => throw new NotSupportedException($"Unsupported point clock model: '{pointClock.Brand}'")
        };
    }
}
