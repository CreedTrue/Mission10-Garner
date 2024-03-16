// Set up the Bowler type and the Team interface
type Bowler = {
  bowlerId: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  teamId: number;
  team: Team;
};

//This allows easy acces to the team data within the bowler type
interface Team {
  teamID: number;
  teamName: string;
  captainID?: number;
}

export type { Bowler, Team };
