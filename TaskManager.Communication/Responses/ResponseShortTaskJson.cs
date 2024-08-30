﻿using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public TaskStatusEnum Status { get; set; }
}
