﻿using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.DeviceSync.Infrastructure.PointClockGateways;
internal class ControlIDGateway(PointClock pointClock) : IPointClockGenericGateway
{
    private readonly PointClock _pointClock = pointClock;

    public Result SetDateTime()
    {
        Console.WriteLine($"{nameof(ControlIDGateway)}: Sending request to https://{_pointClock.Ip}:{_pointClock.Port}");

        return new SetDateTimeSuccess(_pointClock.Ip);
    }
}
