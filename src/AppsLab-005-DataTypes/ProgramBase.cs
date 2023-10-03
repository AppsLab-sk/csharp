using System.Diagnostics;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal class ProgramBase1
{
    int mojeCislo = 13; // kompilátor určí, že mojeCislo je int
    string mojeSlovo = "Ahoj, Jacob!"; // kompilátor určí, že mojeSlovo je string
    bool mojaBoolHodnota = true; // kompilátor určí, že mojaBoolKodnota je bool
    DateTime dnesnyDatum = DateTime.Now; // kompilátor určí, že dnesnyDatum je DateTime
}