
/// Hug right side of wall until at the end
/// If right no peek, check front
/// If front no peek check left
/// If left no peek, turn left again and Move 1
/// Rpeeat


while(!AtGoal) {
    if(TurnRightCheck)
        Move();
    else {
        if(TurnCheckFront)
            Move();
        else if (TurnLeftCHeck) 
            Move();
        else {
            TurnLeft();
            Move();
        }
    }

}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion

#region Helper functions

void TurnLeft() {
    Turn();
    Turn();
    Turn();
}

bool TurnRightCheck() {
    Turn();
    if(Peek) 
        return true;
    return false;
}

bool TurnLeftCHeck() {
    TurnLeft();
    if(Peek)
        return true;
    return false;
}

bool TurnCheckFront() {
    TurnLeft();
    if(Peek)
        return true;
    return false;
}

#end region