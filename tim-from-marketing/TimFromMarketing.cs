using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        StringBuilder result = new StringBuilder();

        if (id != null)
            result.Append($"[{id}] - ");

        result.Append($"{name} - ");

        if (department == null)
            result.Append("OWNER");
        else
            result.Append($"{department.ToUpper()}");

        return result.ToString();
    }
}
