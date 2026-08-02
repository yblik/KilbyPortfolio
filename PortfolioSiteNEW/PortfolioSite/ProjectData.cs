using MudBlazor;

namespace PortfolioSiteNEW.PortfolioSite;

public class ProjectInfo
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = Icons.Material.Filled.Code;
    public string Url { get; set; } = "#";
    public List<string> Tags { get; set; } = new();
}

// Single source of truth for project data, so the NavMenu dropdown
// and the Home page grid never fall out of sync.
public static class ProjectData
{
    public static List<ProjectInfo> Projects => new()
    {
        new ProjectInfo
        {
            Title = "Companies House Data Analyser",
            Description = "A Python application for processing UK Companies House data, with BI-style dashboards for exploring and filtering company records.",
            Icon = Icons.Material.Filled.Business,
            Url = "/projects/companies-house",
            Tags = new() { "Python", "Data Analysis", "Dashboards" }
        },
        new ProjectInfo
        {
            Title = "Code Retineo",
            Description = "A C# WinForms desktop app for practising code memorisation and recall through timed, repeatable exercises.",
            Icon = Icons.Material.Filled.Memory,
            Url = "/projects/code-retineo",
            Tags = new() { "C#", "WinForms", "Desktop" }
        },
        new ProjectInfo
        {
            Title = "Networked Arena",
            Description = "A multiplayer Unity game built with Netcode for GameObjects, focused on synced real-time gameplay mechanics.",
            Icon = Icons.Material.Filled.SportsEsports,
            Url = "/projects/networked-arena",
            Tags = new() { "Unity", "C#", "Multiplayer" }
        }
    };
}