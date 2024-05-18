using DataAccess.Models;

namespace DataAccess.Data;
public class SummerProgramData : ISummerProgramData
{
    public List<SummerProgram> GetSummerPrograms()
    {
        return
            [
                new SummerProgram
                {
                    Name = "Research Science Institute (RSI)",
                    Link = "https://www.cee.org/programs/research-science-institute",
                    Description = "The RSI (Research Science Institute) Summer Program is an immersive and prestigious experience designed for exceptional high school students passionate about science, technology, engineering, and mathematics (STEM). Hosted by MIT and the Society for Science, RSI offers an unparalleled opportunity for participants to engage in cutting-edge research alongside top-notch faculty mentors and peers from around the world. It is considered the most prestigious summer program for high school students internationally.",
                    Cost = 0,
                    Location = "Boston, MA",
                    Grades = [11]
                },
                new SummerProgram
                {
                    Name = "Princeton Lab Learning Program (LLP)",
                    Link = "https://scienceoutreach.princeton.edu/laboratory-learning-program",
                    Description = "The Laboratory Learning Program is a full-time, free research experience in the sciences or engineering for high school students. Students are included in ongoing research programs where they are closely supervised by Princeton faculty and research staff. The participation dates are customized according to the schedules of the research personnel and the specifics of the project.",
                    Cost = 0,
                    Location = "Princeton, NJ",
                    Grades = [10, 11]
                },
                new SummerProgram
                {
                    Name = "MIT Introduction to Technology, Engineering, and Science (MITES)",
                    Link = "https://mites.mit.edu/discover-mites/mites-summer/",
                    Description = "Join MITES Summer (formerly MITES) for our six-week, on-campus program that immerses students from across the country in life at MIT. You’ll take five rigorous, rewarding math, science, and humanities courses—and discover all you can achieve. You’ll also participate in lab tours and social events, and benefit from college admissions counseling. This national program gives you firsthand insights into the value and reward of STEM degrees and careers, while also developing the academic and personal skills you need for success.",
                    Cost = 0,
                    Location = "Boston, MA",
                    Grades = [11]
                },
                new SummerProgram
                {
                    Name = "Summer Academy for Math and Science (SAMS)",
                    Link = "https://www.cmu.edu/pre-college/academic-programs/sams.html",
                    Description = "Hosted at Carnegie Mellon University, the SAMS program is an intensive, fully-funded research program hosted in-person at the university. The program allows students to develop a deeper understanding of STEM via traditional classroom instruction, through hands-on projects, and sustained engagement with world-renowned faculty and skilled staff mentors. In addition to their academic experiences, students also have the opportunity to collaborate and develop meaningful relationships with peers from across the country.",
                    Cost = 0,
                    Location = "Pittsburgh, PA",
                    Grades = [11]
                },
                new SummerProgram
                {
                    Name = "Summer Science Program (SSP)",
                    Link = "https://summerscience.org/",
                    Description = "The Summer Science Program (SSP) is an academic summer program where high school students experience college-level education and do research in celestial mechanics by studying the orbits of asteroids, biochemistry by studying the kinetic properties of enzymes, or genomics by studying antibiotic resistance.",
                    Cost = 5000,
                    Location = "Varied",
                    Grades = [10, 11]
                },
                new SummerProgram
                {
                    Name = "Anson Clark Scholars",
                    Link = "https://www.depts.ttu.edu/honors/academicsandenrichment/affiliatedandhighschool/clarks/",
                    Description = "The Anson L. Clark Scholar Program is an intensive seven-week summer research program for twelve highly qualified high school juniors and seniors. The Program at Texas Tech University helps the Scholars to have hands-on practical research experience with outstanding and experienced faculty. It is very prestigious but highly selective.",
                    Cost = 0,
                    Location = "Lubbock, Texas",
                    Grades = [11, 12]
                },
                new SummerProgram
                {
                    Name = "Rockefeller University SSRP",
                    Link = "https://www.rockefeller.edu/outreach/ssrp/",
                    Description = "SSRP is a mentored biomedical research program at Rockefeller University. SSRP Scholars will participate on a research team designed and guided by Rockefeller trainees. SSRP teams mirror the structure of a Rockefeller laboratory, where one trainee serves as team lead with support from dedicated scientist-mentors. Each team will have their own space in the RockEDU laboratory.",
                    Cost = 0,
                    Location = "New York, NJ",
                    Grades = [11, 12]
                },
                new SummerProgram
                {
                    Name = "Stony Brook University Simons Summer Research Program",
                    Link = "https://www.stonybrook.edu/simons/",
                    Description = "The Simons Summer Research Program gives academically talented, motivated high school students the opportunity to engage in hands-on research in science, math or engineering at Stony Brook University. Simons Fellows work with distinguished faculty mentors, learn laboratory techniques and tools, become part of active research teams, and experience life at a research university.",
                    Cost = 8600,
                    Location = "Stony Brook, New York",
                    Grades = [11, 12]
                },
                new SummerProgram
                {
                    Name = "Boston University RISE",
                    Link = "https://www.bu.edu/summer/high-school-programs/rise-internship-practicum/",
                    Description = "Boston University’s Research in Science & Engineering (RISE) program is one of the most competitive science programs for high school students. The students will spend 6 weeks conducting research under the guidance of bright scientific researchers who will help them improve their STEM skills. The cohort of the RISE program is 130 students. All RISE students will achieve a better understanding of the scientific process, research ethics, how to read a research paper, how to present independent research, and how to network in the science and engineering fields.",
                    Cost = 5350,
                    Location = "Boston, MA",
                    Grades = [11]
                },
                new SummerProgram
                {
                    Name = "Garcia Center for Polymers at Engineered Interfaces at Stony Brook University",
                    Link = "https://www.stonybrook.edu/commcms/garcia/",
                    Description = "The Garcia Summer Program is an intensive 7-week program for high school students with Stony Brook University’s Garcia Center for Polymers at Engineered Interfaces focusing on research about polymer science and technology. Students both receive formal instruction and perform independent research with the help of Garcia Center faculty, students, and staff. Even after these 7 weeks, students can continue with the program and plan a research schedule with a faculty mentor for the school year. To assist with this process is pre-arranged transportation and class schedules, all coordinated with local school boards so that students from further geographical areas can also enroll.",
                    Cost = 7000,
                    Location = "Stony Brook, NY",
                    Grades = [10, 11]
                },
                new SummerProgram
                {
                    Name = "Telluride Association Summer Seminar (TASS)",
                    Link = "https://www.tellurideassociation.org/our-programs/high-school-students/",
                    Description = "The Telluride Association Summer Seminar (TASS) is a free, six-week summer educational experience for high school sophomores and juniors. TASS prepares and inspires promising young students to lead and serve through transformative educational experiences rooted in critical thinking and democratic community. Telluride Association covers all program costs for every student, including tuition, books, room and board, field trips, and facilities fees.",
                    Cost = 0,
                    Location = "Varied",
                    Grades = [10, 11]
                },
                new SummerProgram
                {
                    Name = "Stanford University Mathematics Camp (SuMAC)",
                    Description = "SUMaC provides a rigorous academic program for high school students (for Grade Levels 11-12), including lectures, guided research, and group problem-solving. Students participate in mathematics research alongside Stanford University students and peers.",
                    Cost = 3350,
                    Location = "Hybrid",
                    Grades = [10, 11, 12]
                },
                new SummerProgram
                {
                    Name = "High School Honors Science, Math and Engineering Program (HSHSP)",
                    Description = "The Michigan State University High School Honors Science/Engineering/Mathematics Program (HSHSP) is a seven-week, intensive summer research program designed for motivated students from across the United States who wish to gain more experience conducting research while living on the campus of a major research-intensive university.",
                    Cost = 4000,
                    Location = "East Lansing, Michigan",
                    Grades = [11, 12]
                }
            ];
    }
}
