using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Update;
public class UpdateTaskUseCase
{
    public ResponseTaskJson Execute(int taskId, RequestTaskJson taskData)
    {
        return new ResponseTaskJson
        {
            DateToFinish = taskData.DateToFinish,
            Description = taskData.Description,
            Id = taskId,
            Name = taskData.Name,
            Priority = taskData.Priority,
            Status = taskData.Status,
        };
    }
}
