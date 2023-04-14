using KartGame.KartSystems;

using UnityEngine;


public class InputPlayer2 : BaseInput
{
    public string TurnInputName = "HorizontalPlayer2";
    public string AccelerateButtonName = "Accelerate2";
    public string BrakeButtonName = "Brake2";
    

    public override InputData GenerateInput()
    {
        return new InputData
        {
            Accelerate = Input.GetButton(AccelerateButtonName),
            Brake = Input.GetButton(BrakeButtonName),
            TurnInput = Input.GetAxis("HorizontalPlayer2"),
          
        };
    }
}
