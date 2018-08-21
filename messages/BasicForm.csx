using System;
using Microsoft.Bot.Builder.FormFlow;

public enum TrainedRole { Guerlilla = 1, Crusher, Scav };
public enum FightStyle { Close = 1, Mid, Long };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! What is {&} of your character?")]
    public string Name { get; set; }

    [Prompt("..and a {&}?")]
    public string Nickname { get; set; }

    [Prompt("Please select your trained role {||}")]
    public TrainedRole Role { get; set; }

    [Prompt("Please select your favorite {&} {||}")]
    public FightStyle FightStyle { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
