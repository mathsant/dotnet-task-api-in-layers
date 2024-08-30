using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks =
            [
                new ResponseShortTaskJson { Id = 1, Name = "Estudar C#", Status = Communication.Enums.TaskStatusEnum.IN_PROGRESS },
                new ResponseShortTaskJson { Id = 2, Name = "Estudar RN", Status = Communication.Enums.TaskStatusEnum.IN_PROGRESS },
                new ResponseShortTaskJson { Id = 3, Name = "Estudar Typescript", Status = Communication.Enums.TaskStatusEnum.FINISHED },
            ]
        };
    }
}
