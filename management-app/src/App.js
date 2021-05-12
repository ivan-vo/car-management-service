import './App.css';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Dashboard from './Components/Dashboard';
import DealsForm from './Components/DealsForm';

function App() {
  return (
    <div className="App">
      <Router>
        <Dashboard />
        <Switch>
          <Route path="/deals/created">
            <h1>Create Deals</h1>
            <DealsForm/>
          </Route>
          <Route path="/menegers">
            <h1>Menegers</h1>
          </Route>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
