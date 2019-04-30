namespace ProjectName.Models
{
  public class ProjectVariable
  {
    private string _input1;
    private string _input2;

    public string GetInput1()
    {
      return _input1;
    }

    public void SetInput1(string newInput1)
    {
      _input1 = newInput1;
    }

    public string GetInput2()
    {
      return _input2;
    }

    public void SetInput2(string newInput2)
    {
      _input2 = newInput2;
    }

  }
}
