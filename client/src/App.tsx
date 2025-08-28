import { List, ListItem, ListItemText, Typography } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";

function App() {
  const [services, setServices] = useState<Service[]>([]);

  useEffect(() => {
    axios
      .get<Service[]>("https://localhost:5001/api/services")
      .then((response) => setServices(response.data));

    return () => {};
  }, []);

  return (
    <>
      <Typography variant="h3">ThanksHomeService</Typography>
      <List>
        {services.map((service) => (
          <ListItem key={service.id}>
            <ListItemText>{service.name}</ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  );
}

export default App;
