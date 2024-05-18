using DataAccess.Models;

namespace DataAccess.Data;
public interface ISummerProgramData
{
    List<SummerProgram> GetSummerPrograms();
}