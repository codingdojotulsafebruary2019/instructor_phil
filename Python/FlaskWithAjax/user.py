
class User:
    def __init__(self, name, location):
        self.name = name
        self.location = location

class Cohort:
    def __init__(self):
        self.students = [
            User("Phil", "Tulsa"),
            User("Clarie", "Tulsa"),
            User("Kyle", "Tulsa"),
            User("Brundige", "Tulsa"),
            User("Jerred", "Tulsa")
        ]
    def add(self, name, location):
        student = User(name, location)
        self.students.append(student)

        return student