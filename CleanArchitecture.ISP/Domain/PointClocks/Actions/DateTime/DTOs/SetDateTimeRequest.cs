﻿using CleanArchitecture.ISP.Domain.PointClocks.Entities;

namespace CleanArchitecture.ISP.Domain.PointClocks.Actions.DateTime.DTOs;
public record SetDateTimeRequest(PointClock[] PointClocks)
{
}
