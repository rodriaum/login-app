namespace Login.Login;

public class Constant
{
    // List of tables to create during initialization
    public static readonly List<string> TablesToCreate = new List<string>
    {
        @"CREATE TABLE IF NOT EXISTS `login` (
                `id` INT AUTO_INCREMENT PRIMARY KEY,
                `email` VARCHAR(100) NOT NULL UNIQUE,
                `password` VARCHAR(255) NOT NULL,
                `code` INT(6) NOT NULL,
                `checked` TINYINT(1) NOT NULL DEFAULT 0,
                `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP
        )"
    };
}