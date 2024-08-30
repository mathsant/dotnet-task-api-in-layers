using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriorityEnum Priority { get; set; }
    public DateTime DateToFinish { get; set; }
    public TaskStatusEnum Status { get; set; }
}
