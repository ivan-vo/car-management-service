import './App.css';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import Dashboard from './Components/Dashboard';

function App() {
  return (
    <div className="App">
      <Router>
        <Dashboard />
        <Switch>
          <Route path="/cars">
            <h1>Cars</h1>
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
