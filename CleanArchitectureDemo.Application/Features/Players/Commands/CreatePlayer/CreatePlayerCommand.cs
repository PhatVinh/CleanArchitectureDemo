using CleanArchitectureDemo.Domain.Entities;
using MediatR;
using AutoMapper;

namespace CleanArchitectureDemo.Application.Features.Players.Commands.CreatePlayer
{
	public record CreatePlayerCommand : IRequest<Results<int>>, IMapFrom<Player>
	{

	}
	internal class CreatePlayerCommandHandler
	{
	}
}
