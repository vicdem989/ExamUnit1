

///While not at goal
///check if cell infront is open
/// if check == true => go
/// else turn right
/// if check still false, turn other way twice (left)
/// if still false, go back until no open space


while(!AtGoal) {
    if(Peek) {
        Move();
    } else {
        if(TurnRightCheck())
            Move();
        else if (TurnLeftCHeck()) 
            Move();
        else {
            MoveBack();
            if(TurnRightCheck())
                Move();
            else {
                TurnLeftCHeck();
                Move();
            }
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

void Turn(int amountTurns)
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

bool TurnRightCheck() {
    Turn(1);
    if(Peek) 
        return true;
    return false;
}

bool TurnLeftCHeck() {
    Turn(2);
    if(Peek)
        return true;
    return false;
}

void MoveBack() {
    Turn(2);
    while(Peek) 
        move();
    Turn(2);
}

#end region