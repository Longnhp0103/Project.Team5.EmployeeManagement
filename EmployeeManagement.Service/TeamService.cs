﻿using EmployeeManagement.Repository.Models;
using EmployeeManagement.Repository.Repositories;

namespace EmployeeManagement.Service
{
    public class TeamService : ITeamService
    {
        private ITeamRepository teamRepository;
        private ITeamWorkingShiftRepository workingShiftRepository;
        public TeamService(ITeamRepository teamRepository, ITeamWorkingShiftRepository teamWorkingShiftRepository)
        {
            this.teamRepository = teamRepository;
            this.workingShiftRepository = teamWorkingShiftRepository;
        }
        public void CreateTeam(Team team)
        {
            team.MemberNumber = 1;
            team.Status = true;
            teamRepository.Insert(team);
        }

        public void DeleteTeam(int id)
        {
            Team team = teamRepository.GetById(id);
            if (team != null)
            {
                teamRepository.Delete(team.Id);
            }
        }

        public Team GetTeamById(int id)
        {
            return teamRepository.GetById(id);
        }

        public Task<Team> GetTeamByName(string name)
        {
            return teamRepository.GetTeamByName(name);
        }

        public List<Team> GetTeams()
        {
            return (List<Team>)teamRepository.GetAll();
        }

        public void UpdateTeam(Team team)
        {
            teamRepository.Update(team);
        }

    }
}
