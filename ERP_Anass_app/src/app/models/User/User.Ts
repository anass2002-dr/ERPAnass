export interface User {
  UserID?: string
  FirstName: string
  LastName: string
  Email: string
  Password: string
  Status: string
  Role: string
  CreatedAt: Date
  UpdatedAt?: Date
}
