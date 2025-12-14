namespace app_runner.projects
{
    class PhysicsCalculator_main
    {
        public static void PhysicsCalculator_Runner()
        {

            /*
             תעשה בצורה רצינית עם interface
            Console.WriteLine("Enter the mass?");
            double Mass = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the falling height?");
            double height = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Calculator.potential_height_energy(height, Mass));
            */
        }
    }
    class Calculator
    {

        public class G
        {
            public static double get_g()
            {
                Dictionary<string, double> Gs = new Dictionary<string, double>(){
                    {"Sun", 274.13},
                    {"Mercury", 3.7},
                    {"Venus", 8.9},
                    {"Earth", 9.81},
                    {"Earth's Moon", 1.62 },
                    {"Mars", 3.72},
                    {"Jupiter", 24.79},
                    {"Io (a moon of Jupiter)", 1.796},
                    {"Europa (a moon of Jupiter)", 1.315},
                    {"Ganymede (a moon of Jupiter)", 1.428},
                    {"Saturn", 10.44},
                    {"Titan (a moon of Saturn)", 1.352},
                    {"Enceladus (a moon of Saturn)", 0.113},
                    {"Uranus", 8.69},
                    {"Neptune", 11.15},
                    {"Triton (a moon of Neptune)", 0.78},
                    {"Pluto (a dwarf planetary body)", 0.62},
                    {"Ceres (a dwarf planetary body)", 0.29},
                    {"Eris (a dwarf planetary body)", 0.82},
                    {"Haumea (a dwarf planetary body)", 0.44},
                    {"Makemake (a dwarf planetary body)", 0.5},
                    {"Halley's Comet", 0.0006},
                    {"Eros (an asteroid)", 0.005}
                };

                string planetry_body = "";
                bool not_found = true;
                while (not_found)
                {
                    Console.WriteLine("Enter a planetry_body({0}):", string.Join(", ", new List<string>(Gs.Keys)));
                    planetry_body = Console.ReadLine();

                    //בודק ושומר באיזה מפתחות התנאי נכון
                    var matchingKeys = Gs.Keys.Where(key => key.Contains(planetry_body, StringComparison.OrdinalIgnoreCase));
                    // בודק אם יש בכלל מפתחות שמתאימים לתנאי
                    if (matchingKeys.Any())
                    {
                        planetry_body = matchingKeys.First(); // בוחר את הראשון ברשימת המתאימים
                        not_found = false;
                    }
                    else
                    {
                        Console.WriteLine("planetry_body not found in the list.");
                    }
                }
                return Gs[planetry_body];
            }

            public static double get_g(double weight, double mass)
            {
                // g = w/m
                return weight / mass;
            }

            public static double get_g(double Eh, double mass, double height)
            {
                // g = eh/(m*h)
                return Eh / (mass * height);
            }
        }
        class W
        {
            public static double get_weight(double mass)
            {
                // w = gm
                return G.get_g() * mass;
            }

            public static double get_weight(double Eh, double height)
            {
                // w = eh/h
                return Eh / height;
            }
        }

        class m
        {
            public static double get_mass(double weight)
            {
                // m = w/g
                return weight / G.get_g();
            }

            public static double get_mass(double Eh_or_Ek, double height_or_speed, bool is_Ek_and_speed = false)
            {
                if (is_Ek_and_speed)
                {
                    // m = 2ek/v^2
                    return 2 * Eh_or_Ek / (height_or_speed * height_or_speed);
                }
                // m = eh/h*g
                return Eh_or_Ek / (height_or_speed * G.get_g());
            }

            public static double get_mass(double Eq_or_braking_distence, double c_or_friction, double dT_or_speed, bool is_Eq_and_c_and_dT)
            {
                if (is_Eq_and_c_and_dT)
                {
                    // m = Eq/(c*dT)
                    return Eq_or_braking_distence / (c_or_friction * dT_or_speed);
                }
                // m = 2*(braking_distence/friction)/v*v
                return get_mass(Eq_or_braking_distence / c_or_friction, dT_or_speed);
            }
        }

        class v
        {
            public static double falling_speed(double height)
            {
                //v = sqrt(2gh)
                return Math.Sqrt(2 * G.get_g() * height);
            }

            public static double falling_speed(double Eh, double mass)
            {
                //v = sqrt(2Eh/m)
                return Math.Sqrt(2 * Eh / mass);
            }

            public static double movment_speed(double Ek, double mass)
            {
                //v = sqrt(2Ek/m)
                return Math.Sqrt(2 * Ek / mass);
            }

            public static double car_speed(double reaction_distence, double dt)
            {
                //v = reaction_distence/dt
                return reaction_distence / dt;
            }

            public static double car_speed(double braking_distence, double friction_or_stoping_distence, double mass_or_dt, bool is_friction_and_mass = false)
            {
                if (is_friction_and_mass)
                {
                    //v = sqrt(2*(braking_distence/friction)/m)
                    return movment_speed(braking_distence / friction_or_stoping_distence, mass_or_dt);
                }
                //v = מרחק עצירה - מרחק בלימה / dt
                return (friction_or_stoping_distence - braking_distence) / mass_or_dt;
            }

            public static double escape_velocety(double mass, double r)
            {
                //v = sqrt((2gm)/R)
                return Math.Sqrt(2 * G.get_g() * mass / r);
            }

        }

        class Ek
        {
            public static double movment_energy(double speed, double mass)
            {
                //Ek = m*v*v/2
                return mass * speed * speed / 2;
            }

            public static double get_movment_energy(double braking_distence, double friction)
            {
                //Ek = braking_distence/friction
                return braking_distence / friction;
            }

        }

        class braking_distence
        {
            public static double get_braking_distence(double Ek_or_reaction_distence, double friction_or_stoping_distence, bool is_reaction_distence_and_stoping_distence = false)
            {
                if (is_reaction_distence_and_stoping_distence)
                {
                    //מרחק בלימה =Ek/friction
                    return Ek_or_reaction_distence / friction_or_stoping_distence;
                }
                //מרחק בלימה = מרחק עצירה - מרחק תגובה
                return friction_or_stoping_distence - Ek_or_reaction_distence;
            }

            public static double get_braking_distence(double mass, double speed, double friction)
            {
                //מרחק בלימה =(m*v^2)/2friction
                return mass * speed * speed / 2 * friction;
            }
        }

        class Friction
        {
            public static double get_friction(double braking_distence, double speed)
            {
                //friction = braking_distence/speed
                return braking_distence / speed;
            }

            public static double get_friction(double braking_distence, double speed, double mass)
            {
                //friction = braking_distence/(v*v*m*2)
                return braking_distence / (speed * speed * mass * 2);
            }

        }

        class reaction_distence
        {
            public static double calculate_reaction_distence(double speed, double dt = 0.75f)
            {
                //מרחק תגובה =dt*v
                return dt * speed;
            }

            public static double get_reaction_distence(double stoping_distence, double braking_distence)
            {
                //מרחק תגובה = מרחק עצירה - מרחק בלימה
                return stoping_distence - braking_distence;
            }
        }

        class stoping_distence
        {
            public static double get_stoping_distence(double reaction_distence, double braking_distence)
            {
                //מרחק תגובה + מרחק בלימה = מרחק עצירה
                return reaction_distence + braking_distence;
            }

            public static double get_stoping_distence(double speed, double Ek_or_mass, double friction, double dt = 0.75f, bool is_Ek = false)
            {
                if (is_Ek)
                {
                    //מרחק עצירה = dt
                    return dt * speed + Ek_or_mass / friction;
                }
                //מרחק עצירה = dt
                return dt * speed + Ek_or_mass * speed * speed / 2 * friction;
            }

        }

        class dt
        {
            public static double get_dt(double reaction_distence, double speed)
            {
                // dt = reaction_distence/speed
                return reaction_distence / speed;
            }

            public static double get_dt(double stoping_distence, double braking_distence, double speed)
            {
                // מרחק עצירה - מרחק בלימה / v
                return (stoping_distence - braking_distence) / speed;
            }
        }

        public static double get_height(double Eh, double mass_or_weight, bool is_weight = false)
        {
            if (is_weight)
            {
                // h = eh/w
                return Eh / mass_or_weight;
            }
            //h = eh/mg
            //g in the secound function
            return Eh / W.get_weight(mass_or_weight);
        }

        public static double get_c(double Eq, double mass, double dT)
        {
            // c = Eq/(m*dT)
            return Eq / (mass * dT);
        }

        public static double get_dT(double Eq, double c, double mass)
        {
            // dT = Eq/(c*m)
            return Eq / (c * mass);
        }

        public static double potential_height_energy(double height, double mass_or_weight, bool is_weight = false)
        {
            if (is_weight)
            {
                //Eh = wh
                return mass_or_weight * height;
            }
            //Eh = mgh
            return height * mass_or_weight * G.get_g();
        }

        public static double heat_energy(double mass, double c, double dT)
        {
            //Eq = mc*dT
            return mass * c * dT;
        }

        public static double R(double V, double I)
        {
            //R = V/I
            return V / I;
        }

        public static double I(double R, double V)
        {
            //I = V/R
            return V / R;
        }

        public static double V(double R, double I)
        {
            //V = R*I
            return R * I;
        }
    }
}