using Octokit.Webhooks.Events.PullRequest;
using System.Diagnostics;

PullRequestAction action = PullRequestAction.Assigned;
string correct = (string)action;
string wrong = action.ToString();

Debugger.Break();
