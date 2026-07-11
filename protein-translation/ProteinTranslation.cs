public static class ProteinTranslation
{
    private static string? GetProteinStrand(string strand)
    {
        return strand switch
        {
            "AUG" => "Methionine",
            "UUU" or "UUC" => "Phenylalanine",
            "UUA" or "UUG" => "Leucine",
            "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
            "UGU" or "UGC" => "Cysteine",
            "UAU" or "UAC" => "Tyrosine",
            "UGG" => "Tryptophan",
            "UAA" or "UAG" or "UGA" => "STOP",
            _ => null,
        };
    }

    public static string[] Proteins(string strand)
    {
        List<string> result = new();

        foreach (string s in strand.Chunk(3).Select(c => new string(c)))
        {
            string? protein = GetProteinStrand(s);

            if (protein != null) 
            {
                if (protein == "STOP")
                    break;

                result.Add(protein);
            }
        }
        return result.ToArray();
    }
}