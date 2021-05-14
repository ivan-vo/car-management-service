import './App.css';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Dashboard from './Components/Dashboard';
import DealsForm from './Components/DealsForm';
import TopManager from './Components/TopManager';

function App() {
  return (
    <div className="App">
      <Router>
        <Dashboard />
        <Switch>
          <Route path="/deals/created">
            <DealsForm/>
          </Route>
          <Route path="/menegers">
            <TopManager/>
          </Route>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
